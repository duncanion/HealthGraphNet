﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HealthGraphNet.Models
{
    public class StrengthTrainingActivitiesPastModel : IStrengthTrainingActivitiesModel
    {
        internal const string ContentType = "application/vnd.com.runkeeper.StrengthTrainingActivity+json";

        /// <summary>
        /// The URI for this activity. Read only.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; internal set; }

        /// <summary>
        /// The unique ID of the user for the activity. Read only.
        /// </summary>
        [JsonProperty(PropertyName = "userID")]
        public int UserID { get; internal set; }

        /// <summary>
        /// The starting time for the activity (e.g., Sat, 1 Jan 2011 00:00:00).
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The total calories burned (omitted if not available).
        /// </summary>
        [JsonProperty(PropertyName = "total_calories")]
        public double TotalCalories { get; set; }

        /// <summary>
        /// Any notes that the user has associated with the activity (max. 1024 characters; optional).
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        /// <summary>
        /// The exercises performed during this strength training activity.
        /// </summary>
        [JsonProperty(PropertyName = "exercises")]
        public List<ExercisesModel> Exercises { get; set; }

        /// <summary>
        /// The name of the application that last modified this activity. Read only.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; internal set; }

        /// <summary>
        /// The URI of the comment thread for this activity. Read only.
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; internal set; }

        /// <summary>
        /// The URI of the previous activity in the user's fitness feed (omitted for the oldest activity). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "previous")]
        public string Previous { get; internal set; }

        /// <summary>
        /// The URI of the next activity in the user's fitness feed (omitted for the most-recent activity). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "next")]
        public string Next { get; internal set; }

        /// <summary>
        /// The URI of the fitness activity closest in time to this activity for the user (omitted if no fitness activities have been recorded). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_fitness_activity")]
        public string NearestFitnessActivity { get; internal set; }

        /// <summary>
        /// The URIs of the fitness activities closest in time to this activity for each street teammate (empty if no fitness activities have been recorded). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_teammate_fitness_activities")]
        public List<string> NearestTeammateFitnessActivities { get; internal set; }

        /// <summary>
        /// The URIs of the strength training activities closest in time to this activity for each street teammate (empty if no strength training activities have been recorded). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_teammate_strength_training_activities")]
        public List<string> NearestTeammateStrengthTrainingActivities { get; internal set; }

        /// <summary>
        /// The URI of the background activity closest in time to this activity for the user (omitted if no background activities have been recorded). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_background_activity")]
        public string NearestBackgroundActivity { get; internal set; }

        /// <summary>
        /// The URIs of the background activities closest in time to this activity for each street teammate (empty if no background activities have been recorded). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_teammate_background_activities")]
        public List<string> NearestTeammateBackgroundActivities { get; internal set; }

        /// <summary>
        /// The URI of the sleep measurements closest in time to this activity for the user (omitted if no sleep measurements have been taken). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_sleep")]
        public string NearestSleep { get; internal set; }

        /// <summary>
        /// The URIs of the sleep measurements closest in time to this activity for each street teammate (empty if no sleep measurements have been taken). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_teammate_sleep")]
        public List<string> NearestTeammateSleep { get; internal set; }

        /// <summary>
        /// The URI of the nutrition measurement closest in time to this activity for the user (omitted if no nutrition measurements have been token). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_nutrition")]
        public string NearestNutrition { get; internal set; }

        /// <summary>
        /// The URIs of the nutrition measurement closest in time to this activity for each street teammate (empty if no nutrition measurements have been token). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_teammate_nutrition")]
        public List<string> NearestTeammateNutrition { get; internal set; }

        /// <summary>
        /// The URI of the weight measurement closest in time to this activity for the user (omitted if no weight measurements have been token). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_weight")]
        public string NearestWeight { get; internal set; }

        /// <summary>
        /// The URIs of the weight measurements closest in time to this activity for each street teammate (empty if no weight measurements have been token). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_teammate_weight")]
        public List<string> NearestTeammateWeight { get; internal set; }

        /// <summary>
        /// The URI of the general measurement measurement closest in time to this activity for the user (omitted if no general measurements have been token). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_general_measurement")]
        public string NearestGeneralMeasurement { get; internal set; }

        /// <summary>
        /// The URIs of the general measurements closest in time to this activity for each street teammate (empty if no general measurements have been token). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_teammate_general_measurements")]
        public List<string> NearestTeammateGeneralMeasurements { get; internal set; }

        /// <summary>
        /// The URI of the diabetes measurement closest in time to this activity for the user (omitted if no diabetes measurements have been token). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_diabetes")]
        public string NearestDiabetes { get; internal set; }

        /// <summary>
        /// The URIs of the diabetes measurements closest in time to this activity for each street teammate (empty if no diabetes measurements have been token). Read only.
        /// </summary>
        [JsonProperty(PropertyName = "nearest_teammate_diabetes")]
        public List<string> NearestTeammateDiabetes { get; internal set; }
    }
}