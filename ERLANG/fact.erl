-module(fact).
-export([fact/1]).

fact(1) ->
1;
fact(X) ->
X * fact(X - 1).