using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignPatterns
{
    public interface IWebPage
    {
        public void GetContent();
        
    }
    public interface ITheme
    {
        public string GetColor();
    }

    public class About : IWebPage
    {
        protected ITheme theme;
        public void GetContent()
        {
            Console.WriteLine($"About page in {theme.GetColor()}");
        }

       
        public About(ITheme theme)
        {
            this.theme = theme;
            
        }
    }

    public class HomePage : IWebPage
    {
        protected ITheme theme;

        public void GetContent()
        {
            Console.WriteLine($"Home Page page in {theme.GetColor()}");
        }

        public HomePage(ITheme theme)
        {
            this.theme = theme;
        }
    }

    public class DarkTheme : ITheme
    {
        public string GetColor()
        {
            return "Dark theme";
        }
    }
    public class LightTheme : ITheme
    {
        public string GetColor()
        {
            return "Light Theme";
        }
    }
  
    class Bridge
    {
        static void Main(string[] args)
        {
            DarkTheme dark = new DarkTheme();
            HomePage hp = new HomePage(dark);
            
            LightTheme light = new LightTheme();
            About about = new About(light);
            hp.GetContent();
            about.GetContent();

        }
    }
}
