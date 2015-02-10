var movieModule = angular.module("MoviesModule");
movieModule.controller("MoviesController",[
    "$scope", "apiService", "$log", function ($scope, apiService, $log) {

        $scope.getMovies = function () {

            apiService.setCallString("/Movies");

            apiService.get().success(function (data) {
                $scope.movies = data.value;
                $log.log(data);
            }).error(function(data, status) {
                $scope.status = status;
            });
        };
    }
]);