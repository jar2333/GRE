# GRE: Graph Rewrite Engine

An engine for simple labelled graph rewriting. 

Provides interfaces for implementing subgraph isomorphism algorithms

Included is VF2++ (Jüttner and Madarasi, 2018)
https://www.sciencedirect.com/science/article/abs/pii/S0166218X18300829

For the purposes of graph transformation, all morphisms are assumed to be injective. 
The included VF2 modules produce such morphisms. This assumption may change in the future.

Currently functional:
* naive VF2 Induced Subgraph matching (partially implemented, edge labels not preserved)
* Graph Rewriting through Rewriter objects (functional, not optimized, not all cases tested)

Roadmap:
1) Implement VF2++ fully (in progress)
2) Implement Graph Grammars and Graph Rewriting (in progress)
3) Implement grammar rule parser/serialization
4) Implement Probabilistic Graph Grammars and Probabilistic Rewriting
5) Optimization and cleanup
6) First NuGet release

Extension package planned for Probabilistic Edge Replacement Grammars (PERGs):
* Grammar construction and production weight learner classes (max likelihood estimators from graph data)
  - T. Oates et al (2003), _Estimating Maximum Likelihood Parameters for Stochastic Context-Free Graph Grammars_
  - Aguinaga et al (2016), _Growing Graphs from Hyperedge Replacement Graph Grammars_
  - Wang et al (2018), _Growing Better Graphs With Latent-Variable Probabilistic Graph Grammars_
  - Reddy et al (2019), _Edge Replacement Grammars: A Formal Language Approach for Generatign Graphs_
* Production weight solver classes given graph property probabilities (linear and nonlinear systems of equations)
  - B. Courcelle (1990), _Graph Rewriting: An Algebraic and Logic Approach_
  - M. Mosbah (1996), _Probabilistic Graph Grammars_

Dependencies:
- QuikGraph 2.3.0