using System.Collections.Generic;

namespace Options
{
    public class Option
    {
        private string _optionTextAction, _optionTextDescription;
        protected Option _parentOption;
        private List<Option> _childOption;

        public Option(string optionTextAction, string optionTextDescription, List<Option> childOption)
        {
            _optionTextAction = optionTextAction;
            _optionTextDescription = optionTextDescription;
            _childOption = childOption;
            if(childOption != null)
                _childOption.ForEach(SetParent);
        }

        protected void SetParent(Option option)
        {
            option._parentOption = this;
        }
    }


    public class OptionHidden : Option
    {
        private bool _locked = false;
        
        private OptionHidden(string optionTextAction, string optionTextDescription, List<Option> childOption, bool locked)
            : base(optionTextAction, optionTextDescription, childOption)
        {
            _locked = locked;
        }
    }
}