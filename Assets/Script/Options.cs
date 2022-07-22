using System;
using System.Collections.Generic;
using UnityEngine;

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
        public bool Blocked = false;
        public Option ParentOption;
        public List<Option> ChildOption, UnblockOptions = null;

        public Option(string name, string optionTextDescription, List<Option> childOption = null, bool blocked = false)
        {
            Name = name;
            OptionTextDescription = optionTextDescription;
            ChildOption = childOption;
            Blocked = blocked;
            if(childOption != null)
                ChildOption.ForEach(SetParent);
        }

        public override string ToString()
        {
            string _str = $"{Name} ->  ";
            foreach (Options.Option child in ChildOption)
            {
                _str += child + "|| ";
            }

            return _str;
        }

        protected void SetParent(Option option)
        {
            option.ParentOption = this;
        }

        public Options.Option FindOption(string name, bool state = false)
        {
            if (Name.Equals(name) && state == Blocked)
            {
                return this;
            }
            else if (ChildOption != null)
            {
                foreach (Options.Option child in ChildOption)
                {
                    Options.Option opt = child.FindOption(name, state);
                    if (opt != null)
                    {
                        return opt;
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }
        
        public void Selected()
        {
            //Display description, go into the option
            foreach (Options.Option _option in UnblockOptions)
            {
                _option.BlockChange();
            }
        }

        protected void BlockChange()
        {
            Blocked = !Blocked;
        }
    }
}