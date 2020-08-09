using AutoMapper;
using ExerciseWebsite.Entities;
using ExerciseWebsite.Models.Workout;
using ExerciseWebsite.Models.SetList;
using ExerciseWebsite.Models.Set;
using ExerciseWebsite.Models.Exercise;

namespace ExerciseWebsite.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Workout, WorkoutModel>().ReverseMap();
            CreateMap<UpdateWorkout, Workout>();
            CreateMap<CreateWorkout, Workout>();

            CreateMap<Set, SetModel>().ReverseMap();
            CreateMap<UpdateSet, Set>();

            CreateMap<Exercise, ExerciseModel>().ReverseMap();

            CreateMap<SetList, SetListModel>().ReverseMap();
        }
    }
}
