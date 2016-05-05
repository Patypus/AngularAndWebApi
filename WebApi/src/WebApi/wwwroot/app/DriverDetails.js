var driverDetailsModule = angular.module('DriverDetails',
    [
        'ngRoute',
        'StandingsModule',
        'TeamsModule'
    ]);


driverDetailsModule.config(function($routeProvider) {
    $routeProvider
        .when('/standings', {
            templateUrl: 'app/Standings/standings.html',
            controller: 'StandingsController',
            controllerAs: 'StandingsController',
            requiresLogin: false
        })
        .when('/teams', {
            templateUrl: 'app/Teams/teams.html',
            controller: 'TeamsController',
            controllerAs: 'TeamsController',
            requiresLogin: false
        })
})