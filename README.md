# GRE: Graph Rewrite Engine

An engine for simple labelled graph rewriting. 

Provides interfaces for implementing subgraph isomorphism algorithms

Included is VF2++ (Jüttner and Madarasi, 2018)
https://www.sciencedirect.com/science/article/abs/pii/S0166218X18300829

Currently functional (I think):
* naive VF2 Induced Subgraph matching (only Enumerate method implemented)

Roadmap:
1) Implement VF2++ fully (in progress)
2) Implement Graph Grammars and Graph Rewriting
3) Implement grammar rule parser/serialization
4) Implement Probabilistic Graph Grammars and Probabilistic Rewriting
5) Implement production weight optimizer and learner classes for Probabilistic Edge Replacement Grammars (PERGs)

Dependencies:
- QuikGraph 2.3.0