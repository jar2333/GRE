using System;
using System.Collections.Generic;
using QuikGraph;

namespace GraphRewriteEngine 
{
    public interface IMatcher {

        Morphism Find(UndirectedGraph<Node, LEdge> G1, UndirectedGraph<Node, LEdge> G2);

        IList<Morphism> Enumerate(UndirectedGraph<Node, LEdge> G1, UndirectedGraph<Node, LEdge> G2, int iter = 0);

        bool Exists(UndirectedGraph<Node, LEdge> G1, UndirectedGraph<Node, LEdge> G2);

    }
}