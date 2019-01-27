using System;
using System.Collections.Generic;
using System.Text;

namespace TestXFApp
{
    class ConidInformation
    {
        public string Title { get; set; }
        public string TitleShort { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Address { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }


        public override string ToString()
        {
            return Title;
        }
        public static ConidInformation GetPostList()
        {
            var conidInfo = new ConidInformation
            {
                Title = "Contact information",
                TitleShort = "About",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque dolor orci, fermentum sit amet metus semper, pulvinar placerat dolor. Fusce pellentesque sed felis vitae ultrices. In hac habitasse platea dictumst. Ut ac sodales magna. Aliquam mattis enim ac ex vehicula suscipit. Nullam sed massa lacus. Mauris auctor aliquet mi, a lobortis ligula rhoncus eget. Nullam dictum sollicitudin eros et suscipit. Suspendisse potenti. Suspendisse scelerisque nisi consequat venenatis blandit",
                Author = "Issa Mohamad",
                Address = "gatan 5",
                PhoneNr = "0477-886 606",
                Email = "someone@somewhere.com",
                };

            return conidInfo;
        }
    }
}
