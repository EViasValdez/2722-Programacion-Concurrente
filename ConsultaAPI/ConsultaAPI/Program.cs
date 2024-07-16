using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.Http;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;

namespace ConsultaAPI
{
    class Program
    {
        private static void pokemons(int id, int i)
        {
            // Consultar api rest.
            var usuario = new HttpClient();
            var url = $"https://pokeapi.co/api/v2/pokemon/{id}";
            usuario.DefaultRequestHeaders.Clear();
            var consulta = usuario.GetAsync(url).Result;
            var data = consulta.Content.ReadAsStringAsync().Result;
            try
            {
                // obj dinamico.
                dynamic response = JObject.Parse(data);
                string json = response.ToString();
                dynamic pokemon = JsonConvert.DeserializeObject<dynamic>(json);
                var nombre = pokemon.name;
                Console.WriteLine($"Pokemon No.{i}: {nombre}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"El error es: {ex}");
            }
        }
        private static void users(int id, int a)
        {
            // Consultar api rest.
            var nombres = new HttpClient();
            var url = $"http://api-esp32-alexa.herokuapp.com/api/users/{id}";
            nombres.DefaultRequestHeaders.Clear();
            var conversion = nombres.GetAsync(url).Result;
            var data = conversion.Content.ReadAsStringAsync().Result;

            try
            {
                // obj dinamico.
                dynamic response = JObject.Parse(data);
                string json = response.ToString();
                dynamic user = JsonConvert.DeserializeObject<dynamic>(json);
                // Campos de la api.
                var nombre = user.first_name;
                var apellido = user.last_name;
                Console.WriteLine($"User No.{a}: {nombre} {apellido}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"El error es: {ex}");
            }
        }
        static void hPokemon()
        {
            for (int i = 1; i <= 50; i++)
            {
                Random response = new Random();
                pokemons(response.Next(1, 905), i);
            }
        }
        static void hUser()
        {
            for (int a = 1; a <= 50; a++)
            {
                Random response = new Random();
                users(response.Next(1, 100), a);
            }
        }
        static void Main(string[] args)
        {
            Thread pokerandomH = new Thread(hPokemon);
            Thread useandomH = new Thread(hUser);
            pokerandomH.Start();
            useandomH.Start();

            String[] cincuenta = new string[100];
            cincuenta[0] = "pikachu";
            cincuenta[1] = "bulbasaur";
            cincuenta[2] = "yamask";
            cincuenta[3] = "lugia";
            cincuenta[4] = "togepi";
            cincuenta[5] = "camperl";
            cincuenta[6] = "jigglypuff";
            cincuenta[7] = "riolu";
            cincuenta[8] = "exeggutor";
            cincuenta[9] = "vulpix";
            cincuenta[10] = "wigglytuff";
            cincuenta[11] = "lycanroc-midday";
            cincuenta[12] = "mew";
            cincuenta[13] = "cursola";
            cincuenta[14] = "braixen";
            cincuenta[15] = "charmander";
            cincuenta[16] = "arceus";
            cincuenta[17] = "metapod";
            cincuenta[18] = "articuno";
            cincuenta[19] = "onix";
            cincuenta[20] = "snivy";
            cincuenta[21] = "meowth";
            cincuenta[22] = "zubat";
            cincuenta[23] = "paras";
            cincuenta[24] = "dewott";
            cincuenta[25] = "gallade";
            cincuenta[26] = "diglett";
            cincuenta[27] = "blastoise";
            cincuenta[28] = "latias";
            cincuenta[29] = "greninja";
            cincuenta[30] = "fennekin";
            cincuenta[31] = "vulpix";
            cincuenta[32] = "celebi";
            cincuenta[33] = "geodude";
            cincuenta[34] = "kyurem";
            cincuenta[35] = "blaziken";
            cincuenta[36] = "chespin";
            cincuenta[37] = "pancham";
            cincuenta[38] = "ivysaur";
            cincuenta[39] = "ho-oh";
            cincuenta[40] = "lugia";
            cincuenta[41] = "absol";
            cincuenta[42] = "xerneas";
            cincuenta[43] = "noibat";
            cincuenta[44] = "zeraora";
            cincuenta[45] = "pidgeotto";
            cincuenta[46] = "spearrow";
            cincuenta[47] = "farfetchd";
            cincuenta[48] = "doduo";
            cincuenta[49] = "Nydia";
            cincuenta[50] = "Arluene";
            cincuenta[51] = "Damita";
            cincuenta[52] = "Ezequiel";
            cincuenta[53] = "Emory";
            cincuenta[54] = "Craggie";
            cincuenta[56] = "Kendell";
            cincuenta[57] = "Gisela";
            cincuenta[58] = "Levey";
            cincuenta[59] = "Raquel";
            cincuenta[60] = "Araldo";
            cincuenta[61] = "Donni";
            cincuenta[62] = "Flori";
            cincuenta[63] = "Levey";
            cincuenta[64] = "Abel";
            cincuenta[65] = "Bill";
            cincuenta[66] = "Fanya";
            cincuenta[67] = "Udale";
            cincuenta[68] = "Cord";
            cincuenta[69] = "Engracia";
            cincuenta[70] = "Meris";
            cincuenta[71] = "Clemmie";
            cincuenta[72] = "Osbourn";
            cincuenta[73] = "Donetta";
            cincuenta[74] = "Coreen";
            cincuenta[75] = "Cinda";
            cincuenta[76] = "Kendell";
            cincuenta[77] = "Michelle";
            cincuenta[78] = "Eran";
            cincuenta[79] = "Oralla";
            cincuenta[80] = "Rafe";
            cincuenta[81] = "Hall";
            cincuenta[82] = "Ileana";
            cincuenta[83] = "Brunhilde";
            cincuenta[84] = "Eadith";
            cincuenta[85] = "Stu";
            cincuenta[86] = "Llewellyn";
            cincuenta[87] = "Tiphanie";
            cincuenta[88] = "Baird";
            cincuenta[89] = "Orrin";
            cincuenta[90] = "Jdavie";
            cincuenta[91] = "Hermann";
            cincuenta[92] = "Donetta";
            cincuenta[93] = "Jillayne";
            cincuenta[94] = "Eran";
            cincuenta[95] = "Coreen";
            cincuenta[96] = "Sylvester";
            cincuenta[97] = "Christabella";
            cincuenta[98] = "Maximo";
            cincuenta[99] = "Marjorie";

            for (int indexado = 0; indexado < cincuenta.Length; indexado++)
            {
                string mostrar = cincuenta[indexado];
                Console.WriteLine(mostrar + ", ");
            }
        }
    }
}