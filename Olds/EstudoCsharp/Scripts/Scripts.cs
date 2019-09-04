using System;

namespace EstudoCsharp.Scripts
{
    public class Scripts
    {
        public string justDoIt( bool foo = true, bool bar = false)
        {
            return String.Format("foo: {0} bar:{1}", foo, bar)  ;
        }

    }
}
