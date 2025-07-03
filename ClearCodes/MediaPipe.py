import cv2
import mediapipe as mp

cap = cv2.VideoCapture('video_path :)')

mp_pose = mp.solutions.pose
pose = mp_pose.Pose()
mp_draw = mp.solutions.drawing_utils
posList = []

while True :
    success, img = cap.read()
    if not success :
        break

    img_rgb = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)
    results = pose.process(img_rgb)
        
    if results.pose_landmarks :
        lmString = ''
        h, w, _ = img.shape
        for lm in results.pose_landmarks.landmark :
            cx, cy = int(lm.x * w), int(lm.y * h)
            lmString += f'{cx},{h - cy},'

        posList.append(lmString)
        print(len(posList))

        mp_draw.draw_landmarks(img, results.pose_landmarks, mp_pose.POSE_CONNECTIONS)

    cv2.imshow('image', img)
    key = cv2.waitKey(1)

    if key == ord('s') :
        with open('AnimationFile.txt', 'w') as f :
            f.writelines(['%s\n' % item for item in posList])
        break

cap.release()
cv2.destroyAllWindows()