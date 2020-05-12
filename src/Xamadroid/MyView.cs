using Android.Content;
using Android.Widget;

namespace Xamadroid
{
    public class MyView : RelativeLayout
    {
        private readonly Context m_context;

        public MyView(Context context) : base(context)
        {
            m_context = context;
        }
    }
}