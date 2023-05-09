using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Net.Http;

using Xamarin.Essentials;
using System.Net;

namespace App_Banco_Digital.Service
{

    public abstract class Data_Service
    {

        private static readonly string servidor = "http://10.0.2.2:8000";

        protected static async Task<string> GetDataFromService(string rota)
        {

            string resposta_json;

            string uri = servidor + rota;

            if(Connectivity.NetworkAccess != NetworkAccess.Internet)
            {

                throw new Exception("Erro detectado! Certifique-se de estar conectado à internet.");

            }

            else
            {

                using (HttpClient cliente = new HttpClient())
                {

                    HttpResponseMessage resposta = await cliente.GetAsync(uri);

                    if(resposta.IsSuccessStatusCode)
                    {

                        resposta_json = resposta.Content.ReadAsStringAsync().Result;

                    }

                    else
                    {

                        throw new Exception(DecodeServerError(resposta.StatusCode));

                    }

                }

            }

            return resposta_json;

        }

        private static string DecodeServerError(HttpStatusCode status_code)
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

        protected static async Task<string> PostDataToService(string objeto_json, string rota)
        {

            string resposta_json;

            string uri = servidor + rota;

            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {

                throw new Exception("Erro detectado! Certifique-se de estar conectado à internet.");

            }

            else
            {

                using (HttpClient cliente = new HttpClient())
                {

                    HttpResponseMessage resposta = await cliente.PostAsync(uri,
                                                   new StringContent(objeto_json, Encoding.UTF8,
                                                   "application/json"));

                    if (resposta.IsSuccessStatusCode)
                    {

                        resposta_json = resposta.Content.ReadAsStringAsync().Result;

                    }

                    else
                    {

                        throw new Exception(DecodeServerError(resposta.StatusCode));

                    }

                }

            }

            return resposta_json;

        }

    }

}
