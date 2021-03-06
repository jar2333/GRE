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

IN PROGRESS:

1) Implement VF2++ fully (in progress)
   - L. P. Cordella et al (2004), _A (Sub)Graph Isomorphism Algorithm for Matching Large Graphs_
   - C. Vincenzo et al (2015), _VF2 Plus: An Improved version of VF2 for Biological Graphs_
   - A. Jüttner and P. Madarasi (2018), _VF2++—An Improved Subgraph Isomorphism Algorithm_
2) Implement Graph Grammars and Graph Rewriting (in progress)
   - B. König et al (2018), _A Tutorial on Graph Transformation_

LATER: 

3) Implement grammar rule parser/serialization
4) Implement Probabilistic Graph Grammars and Probabilistic Rewriting
   - M. Mosbah (1996), _Probabilistic Graph Grammars_
5) Optimization and cleanup
6) First NuGet release

A future extension package for Probabilistic Edge Replacement Grammars (PERGs) is possible in the future:
* Grammar construction and production weight learner classes
  - T. Oates et al (2003), _Estimating Maximum Likelihood Parameters for Stochastic Context-Free Graph Grammars_
  - Aguinaga et al (2016), _Growing Graphs from Hyperedge Replacement Graph Grammars_
  - Wang et al (2018), _Growing Better Graphs With Latent-Variable Probabilistic Graph Grammars_
  - Reddy et al (2019), _Edge Replacement Grammars: A Formal Language Approach for Generatign Graphs_
* Production weight solver classes given graph property probabilities (linear and nonlinear systems of equations)
  - B. Courcelle (1990), _Graph Rewriting: An Algebraic and Logic Approach_
  - M. Mosbah (1996), _Probabilistic Graph Grammars_

Dependencies:
- QuikGraph 2.3.0