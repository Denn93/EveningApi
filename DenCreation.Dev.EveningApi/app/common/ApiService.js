var module = angular.module("CommonModule");
module.factory("apiService", [
    "$http", "$log",function($http, $log) {

        var service = {};
        var callString = "";
        var params = "";


        var buildCallstring = function() {
            callString = callString + params;
            $log.info(callString);
        };


        service.setCallString = function(data) {
            callString = data;
        };

        service.setParams = function (data) {
            params = data;
        };

        

        service.get = function () {
            buildCallstring();
            return $http.get(callString);
        };

        return service;
    }
]);