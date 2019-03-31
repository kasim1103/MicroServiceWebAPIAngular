var app = angular.module("ProvincesApp", ["ProvincesApp.ProvincesController", "ngRoute"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.
    when("/", { templateUrl: "/Partials/ProvinceList.html", controller: "MainController" }).
    otherwise({ redirectTo: "/" });
}])