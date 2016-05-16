var teamsModule = angular.module('TeamsModule', []);

teamsModule.controller('TeamsController', function ($scope, $http) {
    var self = this;

    self.message = "Teams page";

    self.displayTitle = function () {
        return "Details:";
    }

    $http({
        method: 'GET',
        url: '/api/Teams/GetAllTeamNames'
    }).then(function successCallback(response) {
        debugger;

    }, function errorCallback(response) {

    });
});