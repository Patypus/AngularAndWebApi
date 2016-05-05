var driverDetailsModule = angular.module('DriverDetails',
    [
        'ngRoute',
        'TeamsModule'
    ]);


driverDetailsModule.config(function($routeProvider) {
    $routeProvider
        .when('/teams', {
            templateUrl: 'app/Teams/teams.html',
            controller: 'TeamsController',
            controllerAs: 'TeamsController',
            requiresLogin: false
        })
})