var movieController = angular.module("MoviesModule");
movieController.controller("moviesController", [
    "$scope", function($scope) {

        $scope.title = "Movie Title page";
    }
]);