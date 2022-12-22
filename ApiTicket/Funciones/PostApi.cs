using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTicket.Models;
using static System.Net.WebRequestMethods;
using System.IdentityModel.Protocols.WSTrust;
using System.Net;

namespace ApiTicket.Funciones
{
     class PostApi
    {

        public void getApi()
        {
            string apiEndPoint = System.Configuration.ConfigurationManager.AppSettings["apiEndPoint"].ToString();
            string bearerToken = System.Configuration.ConfigurationManager.AppSettings["bearerToken"].ToString();

            var client = new RestClient(apiEndPoint);
            var request = new RestRequest(String.Empty, Method.Get);
            request.AddHeader("accept", "application/json; charset=utf-8");
            request.AddHeader("authorization", "Bearer "+ bearerToken);
            var response = client.Execute(request);
            if (response.IsSuccessful)
            {
                Console.WriteLine("Se hizo la peticion correctamente");
                var respuesta = response.Content;
                Console.WriteLine(respuesta);
            }
            else
            {
                Console.WriteLine("Ocurrio un error en la peticion");
            }
        }


        public void postApi()
        {

            string apiEndPoint = "https://api.hubapi.com/crm/v3/objects/tickets/1332060045";
            //string apiEndPoint = System.Configuration.ConfigurationManager.AppSettings["apiEndPoint"].ToString();
            string bearerToken = System.Configuration.ConfigurationManager.AppSettings["bearerToken"].ToString();


            var client = new RestClient(apiEndPoint);
            var request = new RestRequest(String.Empty, Method.Patch);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json; charset=utf-8");
            request.AddHeader("authorization", "Bearer " + bearerToken);
            request.AddParameter("application/json", "{\"properties\":{\"hs_pipeline\":\"Pipeline de asistencia técnica\",\"hs_pipeline\":\"Pipeline de asistencia técnica\",\"hs_ticket_priority\":\"HIGH\",\"subject\":\"DX2VP5_CANCELACIÓN DE VUELO VIVA**\",\"ruta\":\"MEX\",\"aerolinea\":\"VIVA AEROBUS\",\"tipo_de_incidencia\":\"Afectación\"}}", ParameterType.RequestBody);
        



            var response = client.Execute(request);
            if (response.IsSuccessful)
            {
                Console.WriteLine("Se hizo la peticion correctamente");
                var respuesta = response.Content;
                Console.WriteLine(respuesta);
            }
            else
            {
                Console.WriteLine("Ocurrio un error en la peticion");
                var respuesta = response.ErrorException;
                Console.WriteLine(respuesta);
            }
        }
        
    }
}
