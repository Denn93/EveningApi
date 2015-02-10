var movieModule = angular.module("MoviesModule");
movieModule.controller("MoviesController",[
    "$scope", "moviesService", "$log",function($scope, moviesService, $log) {

        $scope.getMovies = function () {
            $log.log("click");

            moviesService.get().success(function(data) {
                $scope.movies = data.value;
                $log.log(data);
            }).error(function(data, status) {
                $scope.status = status;
            });
        };
    }
]);