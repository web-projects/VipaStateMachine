using helpers;

namespace Verifone.VIPA.Processing
{
    public enum ProcessingResult
    {
        [StringValue("NONE")]
        None,
        [StringValue("SUCCESS")]
        Sucess,
        [StringValue("FAIL")]
        Fail,
        [StringValue("CANCEL")]
        Cancel
    }
}
