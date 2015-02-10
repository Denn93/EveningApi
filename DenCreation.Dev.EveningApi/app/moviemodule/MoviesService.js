var moviesModule = angular.module("MoviesModule");
moviesModule.service("moviesService", [
    "$http", function($http) {

        this.get = function() {
            return $http.get("/Movies");
        };
    }
]);