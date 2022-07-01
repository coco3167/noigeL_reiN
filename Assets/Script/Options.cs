using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

namespace Options
{
    public class Option : MonoBehaviour
    {
        private string _optionTextAction, _optionTextDescription;
        private Option _parentOption;
        private List<Option> _childOption;

        protected Option(string optionTextAction, string optionTextDescription, Option parentOption, List<Option> childOption)
        {
            _optionTextAction = optionTextAction;
            _optionTextDescription = optionTextDescription;
            _parentOption = parentOption;
            _childOption = childOption;
        }
    }


    public class OptionHidden : Option
    {
        private bool _locked = false;
        
        private OptionHidden(string optionTextAction, string optionTextDescription, Option parentOption, List<Option> childOption, bool locked)
            : base(optionTextAction, optionTextDescription, parentOption, childOption)
        {
            _locked = locked;
        }
    }
}