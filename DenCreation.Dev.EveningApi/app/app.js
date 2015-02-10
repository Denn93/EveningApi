var app = angular.module("app", ["MoviesModule"]);
var commonModule = angular.module("CommonModule", []);
var moviesModule = angular.module("MoviesModule", ["CommonModule"]);