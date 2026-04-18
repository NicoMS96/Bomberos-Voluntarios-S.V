using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Models;

namespace Logica
{
    public class AsistenciasLogica
    {
        AsistenciasDatos AsistDatos;
        BomberosDatos bomberosDatos; 
        public AsistenciasLogica()
        {
            AsistDatos = new AsistenciasDatos();
            bomberosDatos = new BomberosDatos(); 
        }

        public int ObtenerRegistrarFecha()
        {
            int fechaId;
            DateTime fecha = DateTime.Now;
            if (AsistDatos.VerificarFecha(fecha) == null)
            {
                fechaId = AsistDatos.RegistrarFecha(fecha);

                DataTable bomberos = bomberosDatos.ObtenerBomberos(1);
                foreach (DataRow bombero in bomberos.Rows)
                {

                    int codigoBombero = Convert.ToInt32(bombero["COD. BOMB"]);

                    Asistencia asist = new Asistencia()
                    {
                        AsistenciaValor = 'A',
                        FechaId = fechaId,
                        TipoAsistenciaId = 2,
                        CodigoBombero = codigoBombero
                    };

                    AsistDatos.RegistrarAusencias(asist);

                }
            }
            else
            {
                fechaId = AsistDatos.ObtenerFechaId(fecha);
            }

            return fechaId;

        }


        private string RegistrarHora(int codigoBombero, char tipoHora)
        {
            DataRow ultimoRegistro = AsistDatos.ObtenerUltimoRegistro(codigoBombero);
              
            if (ultimoRegistro == null)
            {
                if (tipoHora == 'S')
                    return "El bombero no está actualmente ingresado.";  
            }
            else
            {
                char ultimoTipo = Convert.ToChar(ultimoRegistro["tipo"]);

                // Validar si ya está ingresado o no
                if (tipoHora == 'E' && ultimoTipo == 'E')
                    return "Este bombero ya está ingresado.";
                if (tipoHora == 'S' && ultimoTipo == 'S')
                    return "El bombero no está actualmente ingresado.";
            }

            int fechaId = ObtenerRegistrarFecha();

            Asistencia asiste = new Asistencia()
            {
                FechaId = fechaId,
                CodigoBombero = codigoBombero,
                AsistenciaValor = '1',
                TipoAsistenciaId = 2
            };

            if (tipoHora == 'E')
                AsistDatos.ActualizarAsistencia(asiste);

            int resultado = AsistDatos.RegistrarHora(asiste, tipoHora);

            return resultado > 0 ? null : "Hubo un error al registrar la hora.";
        }

        public string RegistrarAsistencia(int codigoBombero)
        {
            return RegistrarHora(codigoBombero, 'E');
        }

        public string RegistrarSalida(int codigoBombero)
        {
            return RegistrarHora(codigoBombero, 'S');
        }

        /*
        public DataTable AsistenciaInstitucion()
        {
            DataTable asistencias = AsistDatos.AsistenciaInstitucion();
            asistencias.Columns.Add("horasDia", typeof(float));
             
            float horasTotal;
            int puntos;
            int cambioDia=0;
            foreach (DataRow asistencia in asistencias.Rows)
            {
                int dia = Convert.ToInt32(asistencia["DIA"]);
                int fechaId = Convert.ToInt32(asistencia["fechaId"]);
                string tipo = asistencia["tipo"].ToString();  
                DateTime hora = DateTime.Parse(asistencia["hora"].ToString());
                DateTime entrada;
                DateTime salida;
                
                TimeSpan HoraDia;
                if(cambioDia == 0 || cambioDia == dia)
                {
                    if(tipo == "E")
                    {
                        entrada = hora;
                    }else if (tipo == "S")
                    {
                        salida = hora;
                    }

                    
                }


                cambioDia = dia;
            }


            return asistencias;
        }
        */

        public List<BomberoAsistencia> AsistenciaInsti()
        {
            DataTable asistencias = AsistDatos.AsistenciaInstitucion();
            List<BomberoAsistencia> listaAsistencias = new List<BomberoAsistencia>();

            // Variables para realizar el seguimiento
            int bomberoAnterior = -1;
            int fechaAnterior = -1;
            float horasDia = 0;
            DateTime? entrada = null;
            string nombreCompleto = "";

            // Iterar sobre cada fila del DataTable
            foreach (DataRow asistencia in asistencias.Rows)
            {
                int codigoBombero = Convert.ToInt32(asistencia["codigoBombero"]);
                int fechaId = Convert.ToInt32(asistencia["fechaId"]);
                string tipo = asistencia["tipo"].ToString(); // 'E' para entrada, 'S' para salida
                DateTime hora = DateTime.Parse(asistencia["hora"].ToString());

                // Si la fila tiene un nombre válido
                if (asistencia["NOMBRE Y APELLIDO"] != DBNull.Value)
                {
                    nombreCompleto = asistencia["NOMBRE Y APELLIDO"].ToString();
                }

                // Si cambia el bombero o la fecha, guardar el anterior registro en la lista
                if (codigoBombero != bomberoAnterior || fechaId != fechaAnterior)
                {
                    if (bomberoAnterior != -1 && fechaAnterior != -1)
                    {
                        // Agregar el último registro acumulado a la lista
                        listaAsistencias.Add(new BomberoAsistencia
                        {
                            CodigoBombero = bomberoAnterior,
                            NombreCompleto = nombreCompleto,
                            FechaId = fechaAnterior,
                            HorasTrabajadas = horasDia
                        });
                    }

                    // Resetear las variables para el nuevo bombero/fecha
                    horasDia = 0;
                    entrada = null;
                }

                // Calcular horas trabajadas para el mismo bombero/fecha
                if (tipo == "E")
                {
                    entrada = hora; // Guardar la hora de entrada
                }
                else if (tipo == "S" && entrada.HasValue)
                {
                    horasDia += (float)(hora - entrada.Value).TotalHours;
                    entrada = null; // Resetear para la próxima entrada
                }

                // Actualizar los valores actuales
                bomberoAnterior = codigoBombero;
                fechaAnterior = fechaId;
            }

            // Agregar el último registro si quedó sin procesar
            if (bomberoAnterior != -1 && fechaAnterior != -1)
            {
                listaAsistencias.Add(new BomberoAsistencia
                {
                    CodigoBombero = bomberoAnterior,
                    NombreCompleto = asistencias.Rows[asistencias.Rows.Count - 1]["NOMBRE Y APELLIDO"].ToString(),
                    FechaId = fechaAnterior,
                    HorasTrabajadas = horasDia
                });
            }


            return listaAsistencias;
        }



    }
}
