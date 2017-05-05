(function () {
    'use strict';

    function CustomersController($scope, $http, $log) {

        console.log("test");

        //Allow easy logging
        $scope.logIt = $log;

        //Because this is outside of a function it is executed straight away
        $http({
            method: 'GET',
            url: '/api/customers'
        }).then(function ASuccess(response) {
            console.log("Got customers");
            console.log(response.data);
            $scope.customers = response.data;
        }, function AnError(response) {
            console.log("Didn't get customers");
            $scope.ErrorInformation = response.statusText;
        });


        //Function to remove a customer
        $scope.removeCustomer = function (id) {
            $http({
                method: 'DELETE',
                url: '/api/customers/' + id
            }).then(function ASuccess(response) {
                console.log("Success deleting");
            }, function AnError(response) {
                console.log("Didn't delete");
            });
        };

        //Function to add a customer
        $scope.addCustomer = function () {
            $http({
                method: 'POST',
                url: '/api/customers/'
            }).then(function ASuccess(response) {
                console.log('Success adding new customer');
            }, function AnError(response) {
                console.log("Didn't add");
            });
        };
    };


    //This angular directive works
    angular
        .module('Customers', [])
        .controller('CustomersController', CustomersController)
        .directive('directive', function () {
            return {
                templateUrl: '/Client/Views/CustomerView.html',
            };
        });

})();



    







