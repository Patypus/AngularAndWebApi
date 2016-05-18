var teamsModule = angular.module('TeamsModule', []);

teamsModule.controller('TeamsController', function ($scope, $http) {
    var self = this;

    self.message = "Teams page";
    self.teamsList = [];
    self.selectedTeam = null;

    self.displayTitle = function () {
        return "Details:";
    }

    self.search = function () {
        alert("Selected: " + self.selectedTeam);
    }

    $http({
        method: 'GET',
        url: 'api/team/getAllTeamNames'
    }).then(function successCallback(response) {
        debugger;
        self.teamsList = response.data;
    }, function errorCallback(response) {
        alert("Unable to load team details from server. Error code: " + response.status);
    });
});