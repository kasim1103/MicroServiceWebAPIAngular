angular.module("CrudDemoApp.controllers", []).
controller("MainController", function ($scope, PlayerService) {
    $scope.message = "Main Controller";

    PlayerService.GetPlayerFromDb().then(function (d) {

        $scope.listPlayers = d.data.list;
    })

    $scope.DeletePlayer = function (id, index) {
        $scope.listPlayers.splice(index, 1)
        PlayerService.DeletePlayer(id);
    }
}).
    controller("AddPlayerController", function ($scope, PlayerService) {
        $scope.message = "Add Player Details";

        $scope.AddPlayer = function () {
            PlayerService.AddPlayer($scope.player);
        }
    }).
    controller("EditPlayerController", function ($scope, PlayerService, $routeParams) {
        $scope.message = "Update Player Details";

        var id = $routeParams.id;

        PlayerService.GetPlayerById(id).then(function (d) {
            $scope.player = d.data.player;
        })

        $scope.UpdatePlayer = function () {
            PlayerService.UpdatePlayer($scope.player);
        }
    }).
factory("PlayerService", ["$http", function ($http) {

    var fac = {};

    fac.GetPlayerFromDb = function () {
        return $http.get("/Player/GetPlayers");
    }

    fac.GetPlayerById = function (id) {
        return $http.get("/Player/GetPlayerById", { params: { id: id } });
    }

    fac.AddPlayer = function (player) {
        $http.post("/Player/AddPlayer", player).success(function (response) {
            alert(response.status);
        })
    }

    fac.UpdatePlayer = function (player) {
        $http.post("/Player/UpdatePlayer", player).success(function (response) {
            alert(response.status);
        })
    }

    fac.DeletePlayer = function (id) {
        $http.post("/Player/DeletePlayer", { id: id }).success(function (response) {
            alert(response.status);
        })
    }

    return fac;
}])