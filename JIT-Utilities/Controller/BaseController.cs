using JIT_Utilities.Controller.Listeners;

namespace JIT_Utilities.Controller
{
    abstract class BaseController : BaseListener
    {
        public BaseController() { }

        public abstract object OnInteract(object input);
    }
}
