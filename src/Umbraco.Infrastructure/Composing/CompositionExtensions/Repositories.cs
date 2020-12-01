﻿using Umbraco.Core.Builder;
using Umbraco.Core.Persistence.Repositories;
using Umbraco.Core.Persistence.Repositories.Implement;

namespace Umbraco.Core.Composing.CompositionExtensions
{
    /// <summary>
    /// Composes repositories.
    /// </summary>
    internal static class Repositories
    {
        public static IUmbracoBuilder ComposeRepositories(this IUmbracoBuilder builder)
        {
            // repositories
            builder.Services.AddUnique<IAuditRepository, AuditRepository>();
            builder.Services.AddUnique<IAuditEntryRepository, AuditEntryRepository>();
            builder.Services.AddUnique<IContentTypeRepository, ContentTypeRepository>();
            builder.Services.AddUnique<IDataTypeContainerRepository, DataTypeContainerRepository>();
            builder.Services.AddUnique<IDataTypeRepository, DataTypeRepository>();
            builder.Services.AddUnique<IDictionaryRepository, DictionaryRepository>();
            builder.Services.AddUnique<IDocumentBlueprintRepository, DocumentBlueprintRepository>();
            builder.Services.AddUnique<IDocumentRepository, DocumentRepository>();
            builder.Services.AddUnique<IDocumentTypeContainerRepository, DocumentTypeContainerRepository>();
            builder.Services.AddUnique<IDomainRepository, DomainRepository>();
            builder.Services.AddUnique<IEntityRepository, EntityRepository>();
            builder.Services.AddUnique<IExternalLoginRepository, ExternalLoginRepository>();
            builder.Services.AddUnique<ILanguageRepository, LanguageRepository>();
            builder.Services.AddUnique<IMacroRepository, MacroRepository>();
            builder.Services.AddUnique<IMediaRepository, MediaRepository>();
            builder.Services.AddUnique<IMediaTypeContainerRepository, MediaTypeContainerRepository>();
            builder.Services.AddUnique<IMediaTypeRepository, MediaTypeRepository>();
            builder.Services.AddUnique<IMemberGroupRepository, MemberGroupRepository>();
            builder.Services.AddUnique<IMemberRepository, MemberRepository>();
            builder.Services.AddUnique<IMemberTypeRepository, MemberTypeRepository>();
            builder.Services.AddUnique<INotificationsRepository, NotificationsRepository>();
            builder.Services.AddUnique<IPublicAccessRepository, PublicAccessRepository>();
            builder.Services.AddUnique<IRedirectUrlRepository, RedirectUrlRepository>();
            builder.Services.AddUnique<IRelationRepository, RelationRepository>();
            builder.Services.AddUnique<IRelationTypeRepository, RelationTypeRepository>();
            builder.Services.AddUnique<IServerRegistrationRepository, ServerRegistrationRepository>();
            builder.Services.AddUnique<ITagRepository, TagRepository>();
            builder.Services.AddUnique<ITemplateRepository, TemplateRepository>();
            builder.Services.AddUnique<IUserGroupRepository, UserGroupRepository>();
            builder.Services.AddUnique<IUserRepository, UserRepository>();
            builder.Services.AddUnique<IConsentRepository, ConsentRepository>();
            builder.Services.AddUnique<IPartialViewMacroRepository, PartialViewMacroRepository>();
            builder.Services.AddUnique<IPartialViewRepository, PartialViewRepository>();
            builder.Services.AddUnique<IScriptRepository, ScriptRepository>();
            builder.Services.AddUnique<IStylesheetRepository, StylesheetRepository>();
            builder.Services.AddUnique<IContentTypeCommonRepository, ContentTypeCommonRepository>();
            builder.Services.AddUnique<IKeyValueRepository, KeyValueRepository>();
            builder.Services.AddUnique<IInstallationRepository, InstallationRepository>();
            builder.Services.AddUnique<IUpgradeCheckRepository, UpgradeCheckRepository>();

            return builder;
        }
    }
}
