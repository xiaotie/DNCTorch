using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DNCTorch.Native
{
    using real = System.Single;
    using ptrdiff_t = System.Int64;

    #region mixin

    public unsafe struct THStorage_
    {
        public real* data;
        public ptrdiff_t size;
        public int refcount;
        public Byte flag;
        public THAllocator* allocator;
        public void* allocatorContext;
        public THStorage_* view;

        [DllImport("ATen.dll")]
        public static extern real* THStorage__data(THStorage_* storage);

        [DllImport("ATen.dll")]
        public static extern ptrdiff_t THStorage__size(THStorage_* storage);

        [DllImport("ATen.dll")]
        public static extern THStorage_* THStorage__new();

        [DllImport("ATen.dll")]
        public static extern THStorage_* THStorage__newWithSize(ptrdiff_t size);

        [DllImport("ATen.dll")]
        public static extern void THStorage_free(THStorage_* storage);

        [DllImport("ATen.dll")]
        public static extern void THStorage_resize(THStorage_* storage, ptrdiff_t size);

        [DllImport("ATen.dll")]
        public static extern void THStorage_fill(THStorage_* storage, real value);

    }

    #endregion

}
