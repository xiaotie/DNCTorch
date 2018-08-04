using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DNCTorch.Native
{
    using real = System.Single;
    using ptrdiff_t = System.Int64;

    public unsafe struct THFloatStorage
    {
        public real* data;
        public ptrdiff_t size;
        public int refcount;
        public Byte flag;
        public THAllocator* allocator;
        public void* allocatorContext;
        public THFloatStorage* view;

        [DllImport("ATen.dll")]
        public static extern real* THFloatStorage_data(THFloatStorage* storage);

        [DllImport("ATen.dll")]
        public static extern ptrdiff_t THFloatStorage_size(THFloatStorage* storage);

        [DllImport("ATen.dll")]
        public static extern THFloatStorage* THFloatStorage_new();

        [DllImport("ATen.dll")]
        public static extern THFloatStorage* THFloatStorage_newWithSize(ptrdiff_t size);

        [DllImport("ATen.dll")]
        public static extern void THFloatStoragefree(THFloatStorage* storage);

        [DllImport("ATen.dll")]
        public static extern void THFloatStorageresize(THFloatStorage* storage, ptrdiff_t size);

        [DllImport("ATen.dll")]
        public static extern void THFloatStoragefill(THFloatStorage* storage, real value);

    }

}
