using System;
using System.Web;
using Game;   // Dùng DLL Game

namespace WebApplication1
{
    public partial class api : System.Web.UI.Page
    {
        private static Class1 engine = new Class1(); // static để giữ trạng thái game

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "application/json";

            string word = Request.QueryString["word"];
            if (string.IsNullOrEmpty(word))
            {
                Response.Write("{\"error\":\"missing word\"}");
                return;
            }

            GameState state = engine.GetState(word);

            // Tự build JSON string (vì .NET 2.0 chưa có serializer)
            string enemies = "";
            if (state.Enemies != null && state.Enemies.Length > 0)
            {
                enemies = "\"" + string.Join("\",\"", state.Enemies) + "\"";
            }

            string json = "{"
                        + "\"Score\":" + state.Score + ","
                        + "\"Enemies\":[" + enemies + "]"
                        + "}";

            Response.Write(json);
        }
    }
}
