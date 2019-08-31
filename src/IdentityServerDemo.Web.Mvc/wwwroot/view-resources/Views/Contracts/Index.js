(function() {
    $(function() {

        var _contractService = abp.services.app.contract;
        var _$modal = $('#ContractCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate();

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var contract = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js
            
            abp.ui.setBusy(_$modal);
            _contractService.createContract(contract).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new user!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });
        
        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });
    });
})();