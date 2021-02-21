using System;

namespace AdapterPattern
{
    public class ImageView
    {
        private readonly Image _image;

        public ImageView(Image image)
        {
            _image = image;
        }

        public void Apply(IFilter filter)
        {
            filter.Apply(_image);
        }
    }
}
