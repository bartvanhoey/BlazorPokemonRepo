using Microsoft.AspNetCore.Components.Forms;

namespace BlazorPokemon.Web.Pages
{
    public class CustomInputSelect<TValue> : InputSelect<TValue>
    {
        protected override bool TryParseValueFromString(
            string value,
            out TValue result,
            out string validationErrorMessage)
        {

            if (typeof(TValue) == typeof(int))
            {
                if (int.TryParse(value, out var resultInt))
                {
                    result = (TValue)(object)resultInt;
                    validationErrorMessage = null;
                    return true;
                }
                else
                {
                    result = default;
                    validationErrorMessage = $"The selected value {value} is not a valid number.";
                    return false;
                }
            }
            if (typeof(TValue) == typeof(int?))
            {
                if (int.TryParse(value, out int resultInt))
                {
                    result = (TValue)(object)resultInt;
                    validationErrorMessage = null;
                    return true;
                }
                else if (value == null)
                {
                    result = (TValue)(object)value;
                    validationErrorMessage = null;
                    return true;
                }
                else
                {
                    result = default;
                    validationErrorMessage = $"The selected value {value} is not a valid number.";
                    return false;
                }
            }

            return base.TryParseValueFromString(value, out result, out validationErrorMessage);
        }
    }
}