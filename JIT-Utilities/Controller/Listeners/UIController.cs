namespace JIT_Utilities.Controller.Listeners
{
    class UIController : BaseController
    {
        enum State
        {
            Manipulating,
            Editing,
            Paging,
            Animating
        }

        public UIController()
        {

        }

        public override object OnInteract(object input)
        {
            return null;
        }
    }
}
