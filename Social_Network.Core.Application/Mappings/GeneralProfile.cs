using AutoMapper;
using Social_Network.Core.Application.ViewModels.Comment;
using Social_Network.Core.Application.ViewModels.Friend;
using Social_Network.Core.Application.ViewModels.Publication;
using Social_Network.Core.Application.ViewModels.User;
using Social_Network.Core.Domain.Entities;

namespace Social_Network.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<User, UserViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<User, SaveUserViewModel>()
                .ForMember(dest => dest.ConfirmPassword, opt => opt.Ignore())
                .ForMember(dest => dest.ProfilePicture, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Publication, PublicationViewModel>()
                .ForMember(dest => dest.UserName, opt => opt.Ignore())
                .ForMember(dest => dest.PhotoUserUrl, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Publication, SavePublicationViewModel>()
                .ForMember(dest => dest.PhotoPublicationFile, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.User, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Comment, CommentViewModel>()
                .ForMember(dest => dest.PhotoUserUrl, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Comment, SaveCommentViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.User, opt => opt.Ignore())
                .ForMember(dest => dest.Post, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Friend, FriendViewModel>()
                .ForMember(dest => dest.FriendFirstName, opt => opt.Ignore())
                .ForMember(dest => dest.FriendLastName, opt => opt.Ignore())
                .ForMember(dest => dest.FriendUserName, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());

            CreateMap<Friend, SaveFriendViewModel>()
                .ReverseMap()
                .ForMember(dest => dest.User, opt => opt.Ignore())
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.LastModified, opt => opt.Ignore())
                .ForMember(dest => dest.LastModifiedBy, opt => opt.Ignore());
        }
    }
}
