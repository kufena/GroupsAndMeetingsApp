using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FrontEnd.Pages
{
    public class SignUpModel : PageModel
    {
        public void OnGet(string code)
        {
            Console.WriteLine("Code: " + code);

            // POST to oauth2/token with client_id, client_secret, code, grant_type
            // Authorization: Basic base64(client_id:client_secret) possible.
            // returns:
            // { 
            //                "access_token":"eyJra1example", 
            //                "id_token":"eyJra2example",
            //                "refresh_token":"eyJj3example",
            //                "token_type":"Bearer", 
            //                "expires_in":3600
            //               }
            
            Response.Headers.Append("FilthyCatFlapFlag", new Microsoft.Extensions.Primitives.StringValues(code));
            Redirect("/");
        }
    }
}
