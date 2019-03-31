var app = angular.module("LaeveRequestApp", ["LaeveRequestApp.controllers", "ngRoute"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.
    when("/",
    {
        templateUrl: "/Partials/PlayerList.html",
        controller: "MainController"
    }).
    when("/Add",
    {
        templateUrl: "/Partials/AddPlayer.html",
        controller: "AddPlayerController"
    }).
    when("/Edit/:id",
    {
        templateUrl: "/Partials/EditPlayer.html",
        controller: "EditPlayerController"
    }).
    otherwise({ redirectTo: "/" });
}])