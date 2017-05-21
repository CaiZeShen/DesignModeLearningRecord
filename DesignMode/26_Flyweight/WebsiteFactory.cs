using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._26_Flyweight {
    class WebsiteFactory {
        private Hashtable websites=new Hashtable();

        public int WebsiteCount {
            get { return websites.Count; }
        }

        public Website GetWebsite(string key) {
            if (!websites.Contains(key)) {
                websites.Add(key, new ConcreteWebsite(key));
            }

            return websites[key] as Website;
        }

        
    }
}
