using System.Collections.Generic;

namespace Options
{
    
    [System.Serializable]
    public class Room
    {
        public List<Option> Options = new List<Option>();
    }
    
    
    [System.Serializable]
    public class Option
    {
        public string Name, OptionTextDescription;
        public Option ParentOption;
        public List<Option> ChildOption;

        public Option(string name, string optionTextDescription, List<Option> childOption)
        {
            Name = name;
            OptionTextDescription = optionTextDescription;
            ChildOption = childOption;
            if(childOption != null)
                ChildOption.ForEach(SetParent);
        }

        protected void SetParent(Option option)
        {
            option.ParentOption = this;
        }
    }
}