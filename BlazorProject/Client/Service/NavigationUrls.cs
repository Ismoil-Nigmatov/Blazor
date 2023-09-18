namespace BlazorProject.Client.Service
{
    public class NavigationUrls
    {
        public static Dictionary<string, string> UrlMappings = new Dictionary<string, string>
        {
            { "ToCourses", "/allcourses" },
            { "ToContact", "/contact" },
            { "ToLogin", "/login" },
            { "ToReg", "/registration" },
            { "ToMain", "/" },
            { "ToUser", "/user/course" },
            { "ToHomework", "/homework" },
            {"ToAbout","/aboutus"},
            {"ToUserIndex", "/user"},
            {"ToAnswer","/answer"}
        };
    }
}
