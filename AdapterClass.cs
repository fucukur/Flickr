using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;

namespace Appcent
{
    public class AdapterClass:Android.Support.V7.Widget.RecyclerView.Adapter
    {
        private List<string> listImage;

        public AdapterClass(List<string> listImage)
        {
            this.listImage = listImage;
        }

        public override int ItemCount => throw new System.NotImplementedException();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            throw new System.NotImplementedException();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            throw new System.NotImplementedException();
        }
    }
}