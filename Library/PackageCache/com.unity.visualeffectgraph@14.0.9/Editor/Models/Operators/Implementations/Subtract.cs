namespace UnityEditor.VFX.Operator
{
    [VFXHelpURL("Operator-Subtract")]
    [VFXInfo(category = "Math/Arithmetic")]
    class Subtract : VFXOperatorNumericCascadedUnified
    {
        protected override sealed string operatorName { get { return "Subtract"; } }
        protected override sealed double defaultValueDouble { get { return 0.0; } }

        protected override sealed VFXExpression ComposeExpression(VFXExpression a, VFXExpression b)
        {
            return a - b;
        }
    }
}
