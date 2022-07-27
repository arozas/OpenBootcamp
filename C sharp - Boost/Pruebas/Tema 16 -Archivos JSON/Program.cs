// See https://aka.ms/new-console-template for more information

using System.Net;

Console.WriteLine("ARCHIVO JSON");

//OBTECIÓN DEL JSON
//Como conseguir un JSON de un API y usar su contenido.
//Las API son interfaces que nos permiten obtener información y enviar información.
//son sumamente importantes en programación. Tenemos que recordar que tienen un formato.
//Y debemos respetar este formato para asgurarnos que interactuen de forma adecuada.

/*creamos un request y un response para obtener el JSON que queremos.
 request = es la petición al servidor del API.
 responde = guardamos los datos que obtenemos de la petición
 */
HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://cat-fact.herokuapp.com/facts");
HttpWebResponse response = (HttpWebResponse)request.GetResponse();
//Estamos usando un metodo obsoleto para la obtención del API.
//creamos un stream
Stream stream = response.GetResponseStream();
StreamReader reader = new StreamReader(stream);

//en esta variable guardamos la lectuta de todos los datos que tenemos en el JSON.
// obtenidos los datos ya podemos operar con esos datos.
var json = reader.ReadToEnd();
Console.WriteLine(json);