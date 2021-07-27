# GRE: Graph Rewrite Engine

An engine for simple labelled graph rewriting. 

Provides interfaces for implementing subgraph isomorphism algorithms

Included is VF2++ (Jüttner and Madarasi, 2018)
https://www.sciencedirect.com/science/article/abs/pii/S0166218X18300829

For the purposes of graph transformation, all morphisms are assumed to be injective. 
The included VF2 modules produce such morphisms. This assumption may change in the future.

Currently functional:
* naive VF2 Induced Subgraph matching (partially implemented, edge labels not preserved)
* Graph Rewriting through RewritingSystem (functional, not optimized, not all cases tested)

Roadmap:
1) Implement VF2++ fully (in progress)
2) Implement Graph Grammars and Graph Rewriting (in progress)
3) Implement grammar rule parser/serialization
4) Implement Probabilistic Graph Grammars and Probabilistic Rewriting
5) Implement production weight optimizer and learner classes for Probabilistic Edge Replacement Grammars (PERGs)

Dependencies:
- QuikGraph 2.3.0