using System.Configuration;
using System.Linq;

namespace AWS.SimpleNotificationService.Infrastructure
{
    public class AWSSNSConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsRequired = true, IsDefaultCollection = true)]
        public AWSSNSARNCollection Instances
        {
            get { return (AWSSNSARNCollection)this[""]; }
            set { this[""] = value; }
        }
    }

    public class AWSSNSARNCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new AWSSNSARNElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((AWSSNSARNElement)element).Topic;
        }

        public new AWSSNSARNElement this[string elementName]
        {
            get
            {
                return this.OfType<AWSSNSARNElement>().FirstOrDefault(item => item.Topic == elementName);
            }
        }
    }

    public class AWSSNSARNElement : ConfigurationElement
    {
        [ConfigurationProperty("topic", IsKey = true, IsRequired = true)]
        public string Topic
        {
            get { return (string)base["topic"]; }
            set { base["topic"] = value; }
        }

        [ConfigurationProperty("arn", IsRequired = true)]
        public string ARN
        {
            get { return (string)base["arn"]; }
            set { base["arn"] = value; }
        }
    }
}