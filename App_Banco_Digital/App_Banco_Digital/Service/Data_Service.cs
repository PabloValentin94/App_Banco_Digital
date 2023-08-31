using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using Xamarin.Essentials;
using System.Net;
using System.Net.Http;

namespace App_Banco_Digital.Service
{

    public abstract class Data_Service
    {

        private static readonly string host = "http://10.0.2.2:8000";

        protected static async Task<string> GetDataApi(string rota)
        {

            string json;

            string uri = host + rota;

            if(Connectivity.NetworkAccess != NetworkAccess.Internet)
            {

                throw new Exception("Erro detectado! Certifique-se de estar conectado à internet.");

            }

            else
            {

                using(HttpClient cliente = new HttpClient())
                {

                    HttpResponseMessage requisicao_api = await cliente.GetAsync(uri);

                    ShowMessageInConsole(requisicao_api.Content.ReadAsStringAsync().Result);

                    if(requisicao_api.IsSuccessStatusCode)
                    {

                        json = requisicao_api.Content.ReadAsStringAsync().Result;

                    }

                    else
                    {

                        throw new Exception(ServerErrorValidation(requisicao_api.StatusCode));

                    }

                }

            }

            return json;

        }

        protected static async Task<string> SendDataApi(string objeto_json, string rota)
        {

            string json;

            string uri = host + rota;

            if(Connectivity.NetworkAccess != NetworkAccess.Internet)
            {

                throw new Exception("Erro detectado! Certifique-se de estar conectado à internet.");

            }

            else
            {

                using(HttpClient cliente = new HttpClient())
                {

                    HttpResponseMessage requisicao_api = await cliente.PostAsync(uri,
                                                   new StringContent(objeto_json, Encoding.UTF8,
                                                   "application/json"));

                    ShowMessageInConsole(requisicao_api.Content.ReadAsStringAsync().Result);

                    if(requisicao_api.IsSuccessStatusCode)
                    {

                        json = requisicao_api.Content.ReadAsStringAsync().Result;

                    }

                    else
                    {

                        throw new Exception(ServerErrorValidation(requisicao_api.StatusCode));

                    }

                }

            }

            return json;

        }

        private static string ServerErrorValidation(HttpStatusCode status_code)
        {

            string mensagem_erro;

            switch(status_code)
            {

                case HttpStatusCode.BadRequest:
                    mensagem_erro = "A requisição não pode ser atendida no momento! Tente novamente mais tarde.";
                break;

                case HttpStatusCode.NotFound:
                    mensagem_erro = "Recurso indisponível no momento! Tente novamente mais tarde.";
                break;

                case HttpStatusCode.InternalServerError:
                    mensagem_erro = "Nosso banco de dados está temporariamente indisponível! Tente novamente mais tarde.";
                break;

                case HttpStatusCode.RequestTimeout:
                    mensagem_erro = "O servidor não está respondendo! Tente novamente.";
                break;

                case HttpStatusCode.Forbidden:
                    mensagem_erro = "Recurso temporariamente indisponível! Tente novamente mais tarde.";
                break;

                default:
                    mensagem_erro = "Não foi possível efetuar a operação! Tente novamente mais tarde.";
                break;

            }

            return mensagem_erro;

        }

        private static void ShowMessageInConsole(string texto)
        {

            Console.WriteLine("_______________________________");
            Console.WriteLine(texto);
            Console.WriteLine("_______________________________");

        }

    }

}
