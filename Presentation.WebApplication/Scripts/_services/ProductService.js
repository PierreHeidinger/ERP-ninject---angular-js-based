(function () {
    'use strict';
    app.service('ProductService', Service);

    function Service($http, ProductFactory) {

        const rootServer = window.rootPath;

        var service = {};

        service.getProducts = getProducts;

        return service;

        function getProducts() {

            var request = $http({
                method: "GET",
                url: rootServer + 'WereHouse/productos'
            });

            return (request.then(ProductFactory.handleSuccess, ProductFactory.handleError));
        }



    }
})();
