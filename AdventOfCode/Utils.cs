using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode {
    public static class Utils {

        public static HttpClient httpClient = new HttpClient();

        public static async Task<string> GetPuzzleInput(int year, int day) {
            string url = "https://adventofcode.com/" + year + "/day/" + day + "/input";

            using var request = new HttpRequestMessage(HttpMethod.Get, url);

            request.Headers.Add("Cookie", "session=" + Secrets.SessionToken);

            var response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

    }
}
