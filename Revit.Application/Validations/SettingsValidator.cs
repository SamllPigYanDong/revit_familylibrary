﻿using FluentValidation;

namespace AppFramework.Admin.Validations;

public class SettingsValidator : AbstractValidator<HostSettingsEditModel>
{
    public SettingsValidator()
    {
        //默认邮箱地址格式
        RuleFor(x => x.Email.DefaultFromAddress).EmailAddress();
    }
}