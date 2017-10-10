using System;
using System.Collections.Generic;

namespace pairtree
{
    public class Branch<T>
    {
        //end of the data structure
        Pear<T> Head;

        //Start of the data structure
        Pear<T> Root;

        Branch<T> Up;

        Branch<T> Down;
        
        List<Leaf> Leaves;

    }
}
