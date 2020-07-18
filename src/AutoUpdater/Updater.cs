using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using AutoUpdater.Models;

namespace AutoUpdater
{
    public class Updater
    {
        protected HttpClient HttpClient { get; }

        public Updater(string updateUrl)
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(updateUrl);
        }

        public IEnumerable<Update> GetUpdates()
        {
            return Enumerable.Empty<Update>();
        }


        public bool UpdateAvailiable(string currentVersion)
        {
            return false;
        }

        public void Update(string version)
        {

        }

        public void Update()
        {

        }

    }
}