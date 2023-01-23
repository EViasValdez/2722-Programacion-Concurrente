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
            var Usuario = new HttpClient();
            var Url = $"https://pokeapi.co/api/v2/pokemon/{id}";
            Usuario.DefaultRequestHeaders.Clear();
            var consulta = Usuario.GetAsync(Url).Result;
            var Data = consulta.Content.ReadAsStringAsync().Result;
            try
            {
                // obj dinamico.
                dynamic response = JObject.Parse(Data);
                string json = response.ToString();
                dynamic pokemon = JsonConvert.DeserializeObject<dynamic>(json);
                var Nombre = pokemon.name;
                Console.WriteLine($"Pokemon No.{i}: {Nombre}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"El error es: {ex}");
            }
        }
        private static void users(int id, int a)
        {
            // Consultar api rest.
            var Nombres = new HttpClient();
            var Url = $"http://api-esp32-alexa.herokuapp.com/api/users/{id}";
            Nombres.DefaultRequestHeaders.Clear();
            var Conversion = Nombres.GetAsync(Url).Result;
            var Data = Conversion.Content.ReadAsStringAsync().Result;

            try
            {
                // obj dinamico.
                dynamic response = JObject.Parse(Data);
                string json = response.ToString();
                dynamic user = JsonConvert.DeserializeObject<dynamic>(json);
                // Campos de la api.
                var Nombre = user.first_name;
                var Apellido = user.last_name;
                Console.WriteLine($"User No.{a}: {Nombre} {Apellido}");
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

            String[] Cincuenta = new string[100];
            Cincuenta[0] = "pikachu";
            Cincuenta[1] = "bulbasaur";
            Cincuenta[2] = "yamask";
            Cincuenta[3] = "lugia";
            Cincuenta[4] = "togepi";
            Cincuenta[5] = "camperl";
            Cincuenta[6] = "jigglypuff";
            Cincuenta[7] = "riolu";
            Cincuenta[8] = "exeggutor";
            Cincuenta[9] = "vulpix";
            Cincuenta[10] = "wigglytuff";
            Cincuenta[11] = "lycanroc-midday";
            Cincuenta[12] = "mew";
            Cincuenta[13] = "cursola";
            Cincuenta[14] = "braixen";
            Cincuenta[15] = "charmander";
            Cincuenta[16] = "arceus";
            Cincuenta[17] = "metapod";
            Cincuenta[18] = "articuno";
            Cincuenta[19] = "onix";
            Cincuenta[20] = "snivy";
            Cincuenta[21] = "meowth";
            Cincuenta[22] = "zubat";
            Cincuenta[23] = "paras";
            Cincuenta[24] = "dewott";
            Cincuenta[25] = "gallade";
            Cincuenta[26] = "diglett";
            Cincuenta[27] = "blastoise";
            Cincuenta[28] = "latias";
            Cincuenta[29] = "greninja";
            Cincuenta[30] = "fennekin";
            Cincuenta[31] = "vulpix";
            Cincuenta[32] = "celebi";
            Cincuenta[33] = "geodude";
            Cincuenta[34] = "kyurem";
            Cincuenta[35] = "blaziken";
            Cincuenta[36] = "chespin";
            Cincuenta[37] = "pancham";
            Cincuenta[38] = "ivysaur";
            Cincuenta[39] = "ho-oh";
            Cincuenta[40] = "lugia";
            Cincuenta[41] = "absol";
            Cincuenta[42] = "xerneas";
            Cincuenta[43] = "noibat";
            Cincuenta[44] = "zeraora";
            Cincuenta[45] = "pidgeotto";
            Cincuenta[46] = "spearrow";
            Cincuenta[47] = "farfetchd";
            Cincuenta[48] = "doduo";
            Cincuenta[49] = "Nydia";
            Cincuenta[50] = "Arluene";
            Cincuenta[51] = "Damita";
            Cincuenta[52] = "Ezequiel";
            Cincuenta[53] = "Emory";
            Cincuenta[54] = "Craggie";
            Cincuenta[56] = "Kendell";
            Cincuenta[57] = "Gisela";
            Cincuenta[58] = "Levey";
            Cincuenta[59] = "Raquel";
            Cincuenta[60] = "Araldo";
            Cincuenta[61] = "Donni";
            Cincuenta[62] = "Flori";
            Cincuenta[63] = "Levey";
            Cincuenta[64] = "Abel";
            Cincuenta[65] = "Bill";
            Cincuenta[66] = "Fanya";
            Cincuenta[67] = "Udale";
            Cincuenta[68] = "Cord";
            Cincuenta[69] = "Engracia";
            Cincuenta[70] = "Meris";
            Cincuenta[71] = "Clemmie";
            Cincuenta[72] = "Osbourn";
            Cincuenta[73] = "Donetta";
            Cincuenta[74] = "Coreen";
            Cincuenta[75] = "Cinda";
            Cincuenta[76] = "Kendell";
            Cincuenta[77] = "Michelle";
            Cincuenta[78] = "Eran";
            Cincuenta[79] = "Oralla";
            Cincuenta[80] = "Rafe";
            Cincuenta[81] = "Hall";
            Cincuenta[82] = "Ileana";
            Cincuenta[83] = "Brunhilde";
            Cincuenta[84] = "Eadith";
            Cincuenta[85] = "Stu";
            Cincuenta[86] = "Llewellyn";
            Cincuenta[87] = "Tiphanie";
            Cincuenta[88] = "Baird";
            Cincuenta[89] = "Orrin";
            Cincuenta[90] = "Jdavie";
            Cincuenta[91] = "Hermann";
            Cincuenta[92] = "Donetta";
            Cincuenta[93] = "Jillayne";
            Cincuenta[94] = "Eran";
            Cincuenta[95] = "Coreen";
            Cincuenta[96] = "Sylvester";
            Cincuenta[97] = "Christabella";
            Cincuenta[98] = "Maximo";
            Cincuenta[99] = "Marjorie";

            for (int indexado = 0; indexado < Cincuenta.Length; indexado++)
            {
                string mostrar = Cincuenta[indexado];
                Console.WriteLine(mostrar + ", ");
            }
        }
    }
}