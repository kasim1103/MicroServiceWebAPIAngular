angular.module("ProvincesApp.ProvincesController", []).
controller("MainController", function ($scope, ProvinceService) {
    $scope.message = "Main Controller";

    ProvinceService.GetProvinceFromDb().then(function (d) {
        $scope.listProvinces = d.data.Data;
        console.log($scope.listProvinces);
    })
}).
factory("ProvinceService", ["$http", function ($http) {

    var fac = {};

    fac.GetProvinceFromDb = function()
    {
        return $http.get("http://localhost:30642/api/provinces/");
    }

    return fac;
}])